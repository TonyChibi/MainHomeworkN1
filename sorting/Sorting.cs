class Sorting{
    public string [] sort(string[] str){
    string medium=String.Empty;
    for(int i=0;i<str.Length; i++){
        if(str[i].Length<4){
            medium+=str[i]+"!";
        }
    }
    if(medium.Length>0)
    medium=medium.Remove(medium.Length-1,1);
    string []array=medium.Split("!").Select(x=>x.ToString()).ToArray();
    return array;
    }
}