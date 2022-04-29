function select(Img){
    Img.css("border", "5px solid red");
    Img.data("marked", true);
} 

function unselect(Img){
    Img.css("border", "0px none white");
    Img.data("marked", false);
} 

$(document).ready(function(){
    $('img').click(function() {
        if($(this).data("marked") == false)
        {
            select($(this));
        }
        else
        {
            unselect($(this));
        }
      });
});

function selectall()
{
    $('img').each(function() {
        select($(this));
  });
}

function unselectall()
{
    $('img').each(function() {
        unselect($(this));
  });
}

function list(){
    var text;
    var imgid;
    $('img').each(function(){
        if($(this).data("marked") == true){
            imgid = $(this).attr('id');
            text = $('#log').val();
            text+=imgid + ", ";
            $('#log').val(text);
        }
    })
    $('#log').val(text);
}