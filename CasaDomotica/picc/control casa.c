#include <16F628A.h>
#fuses HS, NOWDT, NOPROTECT, NOBROWNOUT, NOLVP
#use delay (clock = 4000000)
#use rs232(baud=9600, xmit=PIN_B2, rcv=PIN_B1)
#include <stdlib.h>
#include <input.c>
#include <input.c>
#include <string.h>
#byte port_a = 5
#byte port_b = 6

char caracter;

#INT_RDA
void RDA_isr(void)
{
   gets(caracter);
}

void main(void)
{
   enable_interrupts(INT_RDA);
   enable_interrupts(GLOBAL);


   while(TRUE){
     
     output_high(pin_b6);
     delay_ms(100);
     output_low(pin_b6);
     delay_ms(100);
     
     switch(&caracter){
      case "1":
      output_high(pin_b7);
      break;
      
      case "2":
      output_low(pin_b7);
      break;      
     }   
   }
}
