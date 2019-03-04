(function (app) {
    app.LgItemView =
        {
        RefreshLista: function () {
            $(".buscar").click();
            app.helpers.closeModal("LgItemCreatePopup");
            }
        }
})(window.app = window.app || {});