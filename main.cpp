#include <iostream>


using namespace std;

double Priceing();

int main()
{
    double a;
    cout << "Nice to meet you. Please look around our shop. And take your time."<< endl;
    cout << "Here are genres and the exit(leading toward the final step of paying)." << endl;
    cout << "Enter the wanted number and then enter \n\n";
    a = Priceing();
    cout << a << "$";
}
double Priceing(){
    int a, b, sum;
    cout << "Genres: \n 1)RPG \n 2)FPS \n 3)Cars \n 4)Anime 5)Kids \n 6)EXIT \n\N\n";
    cin >> a;
    if(a == 1)
        {cout << "Something";}
        if else(a==2){}
        if else(a==3){}
        if else(a==4){}
        if else(a==5){}
        if else(a==6){}
    return sum;
}
