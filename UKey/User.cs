using System;
using System.Collections.Generic;
using System.Text;

namespace UKey {
public class User {
    public string name;
    private string key_;
    public string GetKey() {
        return this.key_;
    }
    public void SetAgreementA(Agreement agreement, string key, string value) {
    }
    public void SetKey(string key) {
        this.key_ = key;
    }
}
}
