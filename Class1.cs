enum MyEnum
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}
class Count_
{
    public delegate void Count_one(MyEnum co);

    public event Count_one Co_ev;


    public void circle()
    {

        for (MyEnum i = MyEnum.January; i <= MyEnum.December; i++)
        {
            if ((int) i % 3 ==0)
            {
                Co_ev((MyEnum)i);
            }
        }
    }
}
