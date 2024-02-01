using System;
class Program
{
    static void Main()
    {
        Mass[] mass = new Mass[3];
        Mass od_mass = new OneDims();
        Mass td_mass = new TwoDims();
        Mass st_mass = new Steps();
        mass[0] = od_mass;
        mass[1] = td_mass;
        mass[2] = st_mass;
        for (int i = 0; i < 3; i++)
        {
            mass[i].GetMass();
            mass[i].PrintMass();
            mass[i].Average();
        }
    }
}