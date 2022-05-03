#include<16f887.h>
#device ADC=10
#fuses INTRC_IO,NOWDT,PROTECT,NOLVP,MCLR,NOBROWNOUT
#use delay(INTERNAL=4000000)
#use RS232(baud=9600,xmit=PIN_C6,rcv=PIN_C7) //,timeout=100)   
#include "lcd.h"

void main(){
   
   //Bloque de configuracion 
   lcd_init();
   char cCaracter; 
   
   while(true){
      
      printf(lcd_putc, "\fEscriba letra: ");
      printf("Escriba letra\n\r");
      cCaracter = getch(); //Aqui estamos esperando a que llegue un carcater
      lcd_gotoxy(1,2);
      printf(lcd_putc, "Letra: %c", cCaracter);
      printf("Letra: %c\n\r", cCaracter);
      
      switch(cCaracter){
         //Agregamos los casos para que al elegir A encienda el led, al elegir B se apague el led
         case 'A':
            {
               output_high(PIN_A0);
               printf(lcd_putc, "\fEncender Led");
            }
         break;
         case 'B':
            {
               output_low(PIN_A0);
               printf(lcd_putc,"\fApagar Led");
            }
         break;
         default:
            {
               printf(lcd_putc,"\fNA");
            }
         break;
      }
      delay_ms(1500);
   }
}
