// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//By using implicit operator in inmplClass 
//We can assign int value to i, by refering to the object inplClass.
inplClass p = new inplClass();
int i = p;
//But we only reading and assign value to i, so changing value in p object will not affect i value.
p.val = 100;
Console.WriteLine(i);

//Using explicit operator needs casting and would looks like that:
inplClass b = new inplClass();
double doub = (double)b;





//Class with implicit and explicit operators:
public class inplClass
{
    public int val { get; set; } = default;

    //Implicit operator
    public static implicit operator int(inplClass classe)
    {
        return classe.val;
    }

    public static explicit operator double(inplClass classe)
    {
        return classe.val;
    }

}