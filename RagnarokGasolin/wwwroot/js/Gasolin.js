let list = document.getElementById("bandMembers");
let data = [];
let linkList = [];

function SetData(name, url)
{
    data.push(name);
    linkList.push(url);
}

SetData("Kim Larsen", "/Gasolin/KimLarsen");
SetData("Franz Beckerlee", "/Gasolin/Franz Beckerlee");
SetData("Wili Jønsson", "/Gasolin/Wili Jønsson");
SetData("Søren Berlev", "/Gasolin/Søren Berlev");
SetData("Bjørn Uglebjerg", "/Gasolin/Bjørn Uglebjerg");
SetData("gamer", "https://youtube.com");

for (i = 0; i < data.length; i++)
{
    let li = document.createElement("li");
    let a = document.createElement("a");
    a.innerText = data[i];
    li.classList.add("nav-item");
    a.classList.add("nav-link");
    a.classList.add("text-light");
    a.setAttribute("href", linkList[i]);
    li.appendChild(a);
    list.appendChild(li);
}