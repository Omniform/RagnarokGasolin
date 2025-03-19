let list = document.getElementById("bandMembers");
let drIV = document.getElementById("drInterview");
let artistNames = [];
let linkList = [];

list.style.cssFloat = "left";
drIV.style.cssFloat = "right";

drIV.setAttribute("src", "https://www.youtube.com/embed/PoHwxGFGj3s?si=RPJayMzGS4NkDrCK");
drIV.style.scale = "2";

function AddArtist(name, url)
{
    artistNames.push(name);
    linkList.push(url);
}

AddArtist("Kim Larsen", "/Gasolin/KimLarsen");
AddArtist("Franz Beckerlee", "/Gasolin/Franz Beckerlee");
AddArtist("Wili Jønsson", "/Gasolin/Wili Jønsson");
AddArtist("Søren Berlev", "/Gasolin/Søren Berlev");
AddArtist("Bjørn Uglebjerg", "/Gasolin/Bjørn Uglebjerg");
AddArtist("gamer", "https://youtube.com");

for (i = 0; i < artistNames.length; i++)
{
    let li = document.createElement("li");
    let a = document.createElement("a");
    a.innerText = artistNames[i];
    li.classList.add("nav-item");
    a.classList.add("nav-link");
    a.classList.add("text-light");

    a.setAttribute("href", linkList[i]);
    li.appendChild(a);
    list.appendChild(li);
}