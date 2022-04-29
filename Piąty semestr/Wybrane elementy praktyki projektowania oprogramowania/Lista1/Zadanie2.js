var licznik = 0;
for(var i=1; i<100000; i++)
{
    var tmp = i;
    var sum=0;
    var ok = true;
   
    while(tmp>0)
    {
        var pom = tmp%10;
        sum += pom;
        if(i%pom != 0) //Nie trzeba uwarzać na zera bo a/0 daje infinity
        {
            ok = false;
        }
        tmp =Math.floor(tmp/10);
    }
    if(i%sum != 0)
    {
        ok = false;
    }
    if(ok == true)
    {
        console.log(licznik, i);
        licznik++;
    }
}