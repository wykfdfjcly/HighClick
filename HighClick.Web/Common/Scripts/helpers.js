var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('HighClick');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);