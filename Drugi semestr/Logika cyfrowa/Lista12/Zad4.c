#include <stdio.h>

int main()
{
    int t[10];
    printf("%d \n", t[0]);
    t[0] = 0;
    printf("%d \n", t[0]);
    printf("%d \n", &t[0]);
}
