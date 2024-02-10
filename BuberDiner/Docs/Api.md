# Bubadiner API

- [Bubadiner API](#bubadiner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
    "firstName" : "Paula",
    "lastName": "Athejando",
    "email": "paulinha22@outlook.com",
    "password": "12345678Ad"
```

#### Register Response

```json
    200 OK
```

```json
    "id": "49a565a7-4954-435a-9683-c26bc97de768"
    "firstName" : "Paula",
    "lastName": "Athejando",
    "email": "paulinha22@outlook.com",
    "token": "dkasdkads.token"
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```**json**
    "email": "paulinha22@outlook.com",
    "password": "12345678Ad"
```

#### Login Response

```json
    200 OK
```

```json
    "id": "49a565a7-4954-435a-9683-c26bc97de768"
    "firstName" : "Paula",
    "lastName": "Athejando",
    "email": "paulinha22@outlook.com",
    "token": "dkasdkads.token"
```
