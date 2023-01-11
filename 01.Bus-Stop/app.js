async function getInfo() {
 const resultName=document.getElementById('stopName');
 const resultBus=document.getElementById('buses');

 const stopId=document.getElementById('stopId').value;
 const url=`http://localhost:3030/jsonstore/bus/businfo/${stopId}`;
 



 


 try {
 resultName.textContent='Loading...';
 resultBus.replaceChildren();
 const res = await fetch(url);
 const data=await res.json();
 console.log(data)
 if (res.status!==200) {
    throw new Error('Stop ID not found!')
 }
 
 resultName.textContent=data.name;

Object.entries(data.buses).forEach(b=>{
    const liElement=document.createElement('li');
    liElement.textContent=`Bus ${b[0]} arrives in ${b[1]} minutes`
    resultBus.appendChild(liElement);
})

 } catch (error) {
    resultName.textContent='Not Found!'
 }

}