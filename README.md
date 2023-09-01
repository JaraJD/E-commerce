# E-commerceApp

Desarrollo de un software de e-commerce para gestionar productos, categorías, tiendas, usuarios y registros de ventas de cada tienda.

En esta solución se plantea un modelo de datos el cual está compuesto por Category, Product, Role, Sale, Store, User y ProductSaleItem, 
usando una base de datos no relacional específicamente MongoDB.

Para la estructura de la aplicación se decide implementar una arquitectura Limpia o por capas, para garantizar la separación de responsabilidades
e independencia de la aplicación aplicando también principios SOLID y obtener como resultado una aplicación de alta flexibilidad y modularidad.
Aplicando Inversión de dependencias e inyección de dependencias para la comunicación entre las capas mediante abstracciones como interfaces y 
que no sea una dependencia directa entre las capas, esto nos ayuda a que sea una aplicación altamente modular y que con facilidad se pueda adaptar
nuevas funcionalidades como servicios de mensajería, conexiones a diferentes bases de datos, sin afectar el dominio de la aplicación, ya que la capa
de dominio es totalmente agnóstica a las tecnologías que se usen, también se implementan patrones de diseño creacionales, como singleton para utilizar 
una misma instancia para conexiones a bases de datos, de comportamiento como Command para convertir una solicitud en un objeto independiente y contenga 
solo la información sobre la solicitud y Mediador para restringir las comunicaciones directas y que se realicen a través de un objeto mediador.

Para acceder a los endpoint de la aplicación se debe crear un usuario primero y logearse, ya que la aplicación usa JWT para la seguridad y los endpoint 
necesitan token puesto que están protegidos. 

## Arquitectura Basada en :

[Clean architecture (N-Layers)](https://github.com/JaraJD/E-commerce/assets/93845990/470e6918-39d7-464c-9404-df84129072fa)


## Modelo de datos : 

### User : 

```
{
  "email": "user@example.com",
  "username": "string",
  "fullName": "string",
  "address": "string",
  "password": "string",
  "confirmPassword": "string"
}
```

### Category : 

```
{
  "name": "string",
  "description": "string"
}
```

### Product : 

```
{
  "name": "string",
  "price": 0,
  "description": "string",
  "categoryId": "string",
  "storeId": "string",
  "stock": 0
}
```

### Sale :

```
{
  "storeId": "string",
  "userId": "string",
  "totalPrice": 0,
  "products": [
    {
      "productId": "string",
      "quantity": 0
    }
  ],
  "transaccionTime": "2023-08-31T23:56:54.443Z"
}
```

### Store :
```
{
  "name": "string",
  "site": "string"
}
```
