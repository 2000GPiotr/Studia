var i = 0;

function moveFunc()
{
    var boxesName = ['box1', 'box2', 'box3', 'box4', 'box5'];
    var ifUp = true;

        interval = setInterval(function(){ moveElemUp(boxesName[i]); }, 300);   
}

function moveElemUp(boxName)
{
    var boxesName = ['box1', 'box2', 'box3', 'box4', 'box5'];
    if(i == 5)
    {
        clearInterval(interval);
        i=0;
        interval1 = setInterval(function(){ moveElemDown(boxesName[i]); }, 300);
    }
    else{
        document.getElementById(boxName).style.bottom="0px";
        i+=1;
    }
    
    
}

function moveElemDown(boxName)
{
    var boxesName = ['box1', 'box2', 'box3', 'box4', 'box5'];
    if(i == 5)
    {
        clearInterval(interval1);
        i=0;
        interval = setInterval(function(){ moveElemUp(boxesName[i]); }, 300);
    }
    else{
        document.getElementById(boxName).style.bottom="-140px";
        i+=1;
    }
    
}