#include <stdio.h>
#include <stdlib.h>

#define false 0
#define true 1
#define end 3
int main ()
{
    int tmp = 0;
    unsigned int i = 0;//indice
    char fin = false; //bandera que indica fin de algoritmo
    int a[4];//array para almacenar los numeros
    a[0]=10;
    a[1]=1;
    a[2]=6;
    a[3]=8;

    printf("\nElemento a[%d]",a[0]);
    printf("\nElemento a[%d]",a[1]);
    printf("\nElemento a[%d]",a[2]);
    printf("\nElemento a[%d]",a[3]);

    while(fin == false)
    {
        fin = true;
        for(i=0; i < 3; i++)
        {
            if(a[i] > a [i+1])
            {
                tmp = a[i];
                a[i] = a[i+1];
                a[i+1] = tmp;
                fin = false;
            }
        }
    }
    printf("\nElemento a[0]: %d",a[0]);
    printf("\nElemento a[1]: %d",a[1]);
    printf("\nElemento a[2]: %d",a[2]);
    printf("\nElemento a[3]: %d",a[3]);

    return 0;

}
