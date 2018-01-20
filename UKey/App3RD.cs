using System;
using System.Collections.Generic;
using System.Text;

namespace UKey {
public class App3RD {
    public int value;

    public void AddValue(string user, int value) {
    }

    private void SetKeyOK() {
        KeyCenter.Instance.AddOrUpdateKey();
    }

    void CheckAgreement() {
        if(this.value == 100) {
            this.SetKeyOK();
        }
    }
}
}
