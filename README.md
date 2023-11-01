__class: musicalInstrument__
============================
fields:
-------
- code
- name
- manufacturer
- costPrice
- purchasePrice
- stockpile
- providerCode

get:
[https://musicalInstumentsAPI.com/musicalInstument/](https://musicalInstumentsAPI.com/musicalInstument/)    

get(id):
[https://musicalInstumentsAPI.com/musicalInstument/{id}/](https://musicalInstumentsAPI.com/musicalInstument/{id}/)    

post:
[https://musicalInstumentsAPI.com/musicalInstument?code={id}&name=""...](https://musicalInstumentsAPI.com/musicalInstument?code={id}&name=""...)    

put:
[https://musicalInstumentsAPI.com/musicalInstument/{id}?name=""...](https://musicalInstumentsAPI.com/musicalInstument/{id}?name=""...)    

delete:
[https://musicalInstumentsAPI.com/musicalInstument/{id}/](https://musicalInstumentsAPI.com/musicalInstument/{id}/)    


__class: provider__
===================
fields:
-------
- id
- name
- phone
- address

get:
[https://musicalInstumentsAPI.com/provider/](https://musicalInstumentsAPI.com/provider/)

get(id):
[https://musicalInstumentsAPI.com/provider/{id}/](https://musicalInstumentsAPI.com/provider/{id}/)

post:
[https://musicalInstumentsAPI.com/provider?code={id}&name=""...](https://musicalInstumentsAPI.com/provider?code={id}&name=""...)

put:
[https://musicalInstumentsAPI.com/provider/{id}?name=""...](https://musicalInstumentsAPI.com/provider/{id}?name=""...)

delete:
[https://musicalInstumentsAPI.com/provider/{id}/](https://musicalInstumentsAPI.com/provider/{id}/)


__class: customers__
====================
fields:
-------
- id
- name
- phone
- address
- lastPurchaseDate

get:
[https://musicalInstumentsAPI.com/customers/](https://musicalInstumentsAPI.com/customers/)

get(id):
[https://musicalInstumentsAPI.com/customers/{id}/](https://musicalInstumentsAPI.com/customers/{id}/)

post:
[https://musicalInstumentsAPI.com/customers?code=&name=""...](https://musicalInstumentsAPI.com/customers?code=&name=""...)

put:
[https://musicalInstumentsAPI.com/customers/{id}?name=""...](https://musicalInstumentsAPI.com/customers/{id}?name=""...)

delete:
[https://musicalInstumentsAPI.com/customers/{id}/](https://musicalInstumentsAPI.com/customers/{id}/)
