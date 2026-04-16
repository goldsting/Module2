namespace Module.Models;

public class PrivateModel<X>{
        private X _value;
        public void SetValue (X value){
            _value = value;
        }

        public X GetValue()
        {
            return _value;
        }
}
