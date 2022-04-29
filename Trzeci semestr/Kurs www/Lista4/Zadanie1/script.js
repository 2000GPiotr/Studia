function mark()
{
    var text = $('#search').val();
    $( "li" ).each(function() {
        if($(this).text().includes(text))
        {
            $(this).css("background-color", "yellow");
        }
        else
        {
            $(this).css("background-color", "grey");
        }
        
      });
}

function clean(){
    $( "li" ).each(function() {
            $(this).css("background-color", "white");
      });
}

$(document).ready(function(){
    $('#search').keyup(function() {
        var textlength = $('#search').val().length;
        if(textlength >= 2)
        {
            mark();
        }

        if(textlength < 3)
        {
            clean();
        }    
  });
});

