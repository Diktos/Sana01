#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#include <windows.h>

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    double a, b, c, d;
    double x, y, z, r;

    printf("¬вед≥ть число a: ");
    scanf("%lf", &a);
    printf("¬вед≥ть число b: ");
    scanf("%lf", &b);
    printf("¬вед≥ть число c: ");
    scanf("%lf", &c);
    printf("¬вед≥ть число d: ");
    scanf("%lf", &d);

    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) + pow(a, 2) / pow(b, 2);
    y = (5 * (a + b) * (c - d)) / (0.5 * c) + pow(d, 2) * (pow(a, 2) - pow(b, 2)) / (b - a);
    z = (pow((pow(x, 2) - 2 * x), 3) - 4 * (pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
    r = ((0.5 * a + 0.75 * b - 7.0 / 5.0) / (3 * c + 1)) + 1 / (a - c);

    printf("\n–езультати обчислень:\n");
    printf("x = %.4lf\n", x);
    printf("y = %.4lf\n", y);
    printf("z = %.4lf\n", z);
    printf("r = %.4lf\n", r);

    return 0;
}
