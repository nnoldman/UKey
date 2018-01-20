using System;
using System.Collections.Generic;
using System.Text;

namespace UKey {
public class KeyCenter {
    public static KeyCenter Instance {
        get {
            if (sInstance_ == null)
                sInstance_ = new KeyCenter();
            return sInstance_;
        }
    }

    private static KeyCenter sInstance_;

    private static int keyCount_;

    private Dictionary<string, string> values_ = new Dictionary<string, string>();
    private List<string> keys_ = new List<string>();

    public string QueryKey(string key) {
        string ret = string.Empty;
        values_.TryGetValue(key, out ret);
        return ret;
    }

    private bool VertifyKey(string key) {
        return true;
    }
    public string RegistKey(string user) {
        return user;
    }
    public bool AddOrUpdateKey(string key, string value) {
        if(this.VertifyKey(key)) {
            this.values_.Remove(key);
            this.values_.Add(key, value);
            return true;
        }
        return false;
    }
}
}
