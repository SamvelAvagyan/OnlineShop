let btn = document.querySelector("div.dropdown button");
let nav = document.querySelector("div.dropdown-content");
let t = false;

btn.onclick = function(){
    if(t){
        nav.style.display = "none";
        btn.style.backgroundColor = "transparent";
        t = false;
    }else{
        nav.style.display = "block";
        btn.style.backgroundColor = "lightGray";
        t = true;
    }
}