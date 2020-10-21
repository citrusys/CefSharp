var Fluxonaut;
if (!Fluxonaut)
    Fluxonaut = {
        Browser = {},
    };

if (!Fluxonaut.Browser.example)
    Fluxonaut.Browser.example = {};

(function ()
{
    Fluxonaut.Browser.example.alert = function(text)
    {
        alert(text);
    };
})();