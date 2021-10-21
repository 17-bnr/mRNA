mergeInto(LibraryManager.library, {
    OpenNewTab : function(url) {
        var message = Pointer_stringify(url);
        window.open("https://twitter.com/intent/tweet?text=neko","_blank");
    },
});