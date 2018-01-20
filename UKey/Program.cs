using System;

namespace UKey {
class Program {
    static void Main(string[] args) {
        User aUser = new User();
        aUser.name = "auser";
        aUser.SetKey(KeyCenter.Instance.RegistKey(aUser.name));

        User bUser = new User();
        bUser.name = "buser";
        aUser.SetKey(KeyCenter.Instance.RegistKey(aUser.name));
    }
}
}
