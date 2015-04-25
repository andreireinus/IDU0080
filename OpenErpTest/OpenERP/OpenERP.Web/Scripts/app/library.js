var InvoiceNumberHolder = (function () {
    function InvoiceNumberHolder() {
        this.localStorageKey = 'idu0080-invoice-numbers';
    }
    InvoiceNumberHolder.prototype.store = function (n) {
        var items = this.getItems();

        for (var i = 0; i <= items.length; i++) {
            if (items[i] == n) {
                return;
            }
        }

        items.unshift(n);
        items = items.splice(0, 10);
        localStorage.setItem(this.localStorageKey, JSON.stringify(items));
    };

    InvoiceNumberHolder.prototype.getItems = function () {
        if (!this.keyExists()) {
            return [];
        }

        return JSON.parse(localStorage.getItem(this.localStorageKey));
    };

    InvoiceNumberHolder.prototype.keyExists = function () {
        for (var i = 0; i < localStorage.length; i++) {
            if (localStorage.key(i) == this.localStorageKey) {
                return true;
            }
        }

        return false;
    };
    return InvoiceNumberHolder;
})();
//# sourceMappingURL=library.js.map
