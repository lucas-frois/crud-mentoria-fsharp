# crud-mentoria-fsharp

# TODO

## Schema

* Note
```js
const note = {
  id: number
  date: string
  message: string
}
```

* Mentee
```js
const mentee = {
  id: number
  nome: string
  idade: number
  cidade: string
  twitter: string
  contato: string
  faculdade: string
  trabalho: string
  conhecimentos: string
  objetivos: string
}
```

## Histórias

- COMO mentor GOSTARIA de cadastrar as informações de um mentorado PARA visualizá-las futuramente
- COMO mentor GOSTARIA de editar as informações de um mentorado PARA atualizá-las
- COMO mentor GOSTARIA de adicionar anotações para cada mentorado marcando as com data PARA visualizá-las futuramente
- COMO mentor GOSTARIA de editar as anotações de cada mentorado PARA atualizá-las se necessário
- COMO mentor GOSTARIA de importar planilha de mentorados PARA cadastrá-los
## Endpoints

- GET api/notes/{id}
- POST api/notes/{id}
- PUT api/notes/{id}

- GET api/mentees (resumido?)
- GET api/mentees/{id} (completo)
- POST api/mentee
- PUT api/mentee/{id}

## Protótipos
* Tela inicial
![image](https://user-images.githubusercontent.com/38838958/128741009-1fda2256-9868-4a4c-bdd5-17adf9aea5b8.png)

* Tela de cadastro

* Tela de edição
