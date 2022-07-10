/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
var m = document.getElementsByClassName('monney');
for (var i = 0; i < m.length; i++) {
    m[i].innerHTML = m[i].innerHTML.replace(/\D/g, "").replace(/\B(?=(\d{3})+(?!\d))/g, ".");
}

