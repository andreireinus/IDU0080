class InvoiceNumberHolder {
    private localStorageKey: string = 'idu0080-invoice-numbers';

    public store(n: string) {
        var items = this.getItems();

        for (var i = 0; i <= items.length; i++) {
            if (items[i] == n) {
                return;
            }
        }

        items.unshift(n);
        items = items.splice(0, 10);
        localStorage.setItem(this.localStorageKey, JSON.stringify(items));
    }

    private getItems(): string[] {
        if (!this.keyExists()) {
            return [];
        }

        return JSON.parse(localStorage.getItem(this.localStorageKey));
    }

    private keyExists(): boolean {
        for (var i = 0; i < localStorage.length; i++) {
            if (localStorage.key(i) == this.localStorageKey) {
                return true;
            }
        }

        return false;
    }
} 