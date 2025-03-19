let m_cardParentDiv = document.getElementById("bandMembers");
let m_drIV = document.getElementById("drInterview");
let m_artistNames = [];
let m_linkList = [];

m_cardParentDiv.classList.add("container");
m_cardParentDiv.style.cssFloat = "left";

m_drIV.style.cssFloat = "right";

m_drIV.setAttribute("src", "https://www.youtube.com/embed/PoHwxGFGj3s?si=RPJayMzGS4NkDrCK");
m_drIV.style.scale = "2";

function AddArtist(name, url)
{
    m_artistNames.push(name);
    m_linkList.push(url);
}

function CreateCard(title, text, buttonText, link, imgPath)
{
    let cardChildDiv = document.createElement("div");
    let img = document.createElement("img");
    let body = document.createElement("div");
    let header = document.createElement("h5");
    let p = document.createElement("p");
    let a = document.createElement("a");

    cardChildDiv.classList.add("card");
    cardChildDiv.style.width = "18rem";
    cardChildDiv.style.cssFloat = "left";

    img.classList.add("card-img-top");
    img.setAttribute("src", link);
    img.setAttribute("alt", title + " image");
    img.setAttribute("src", imgPath);

    body.classList.add("card-body");

    header.classList.add("card-title");
    header.innerText = title;

    p.classList.add("card-text");
    p.innerText = text;

    a.classList.add("btn");
    a.classList.add("btn-primary");
    a.setAttribute("href", link);
    a.innerText = buttonText;

    body.appendChild(header);
    body.appendChild(p);
    body.appendChild(a);

    cardChildDiv.appendChild(img);
    cardChildDiv.appendChild(body);

    return cardChildDiv;
}

AddArtist("Kim Larsen", "/Gasolin/KimLarsen");
AddArtist("Franz Beckerlee", "/Gasolin/Franz Beckerlee");
AddArtist("Wili Jønsson", "/Gasolin/Wili Jønsson");
AddArtist("Søren Berlev", "/Gasolin/Søren Berlev");
AddArtist("Bjørn Uglebjerg", "/Gasolin/Bjørn Uglebjerg");
AddArtist("gamer", "https://youtube.com");

for (i = 0; i < m_artistNames.length; i++)
{
    // let cardChildDiv = document.createElement("div");
    // let a = document.createElement("a");
    // let cardImage = document.createElement("img");

    // a.innerText = m_artistNames[i];

    // cardChildDiv.classList.add("card");
    // cardChildDiv.style.width = "18rem";

    // a.setAttribute("href", m_linkList[i]);

    m_cardParentDiv.appendChild(CreateCard(m_artistNames[i], "this is it", "press me", m_linkList[i], "..."));
}