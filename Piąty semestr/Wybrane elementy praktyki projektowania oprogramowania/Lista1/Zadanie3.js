var licz=0
for(var i=2; i<100000; i++)
{
    var ok = true;
    for(var j=2; j<i; j++)
    {
        if(i%j == 0)
        {
            ok = false;
            break;
        }
    }
    if(ok)
    {
        console.log(licz, i);
        licz++;
    }
}