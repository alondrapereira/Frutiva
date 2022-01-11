/** Documentation on JavasScript Interoperability, go to JavaScript Initializers:
 * https://docs.microsoft.com/en-us/aspnet/core/blazor/javascript-interoperability/?view=aspnetcore-6.0
 * Documentation on Script Injection:
 * https://docs.microsoft.com/en-us/aspnet/core/blazor/javascript-interoperability/?view=aspnetcore-5.0
 **/
function loadScriptDynamic(src) {
    var customScript = document.createElement('script');
    customScript.setAttribute('src', src);
    document.head.appendChild(customScript);
}
export function beforeStart(options, extensions) {
//console.log("beforeStart");
}
export function afterStarted(blazor) {
// If any other JS lib doesn't work as it should, load it here instead of on _Layout.cshtml from a script tag directly
    loadScriptDynamic('js/nifty.js');
    loadScriptDynamic('vendors/popperjs/popper.min.js');
    loadScriptDynamic('vendors/bootstrap/bootstrap.min.js');
}