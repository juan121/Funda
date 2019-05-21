var media = function ($)
{
    //alert("hi"); //comment
//more comments

    var toggleMediaItems = function () {
        $("#mediaItems").toggle();
    }
    return {
        toggleMediaItems: toggleMediaItems
    }
}(jQuery)