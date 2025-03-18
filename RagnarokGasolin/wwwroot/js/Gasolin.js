let list = document.getElementById("bandMembers");
let artistNames = [];
let linkList = [];

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