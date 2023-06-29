class RandomString{
   public string [] GetRandomStringArray(){
        string[]str=new string[new Random().Next(3,11)];
        for(int i=0; i<str.Length; i++){
            int n= new Random().Next(1,12);
            string element=String.Empty;
            for(int j=0;j<n;j++){
                element+=Convert.ToChar(new Random().Next(35,127));     //ASCII from "#" to "~"
            }
            str[i]=element;
        }
        return str;
    }
}