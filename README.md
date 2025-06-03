

## Como usar o GitHub
Baixar os arquivos do Git.
```
git clone https://github.com/TheMarciel/dztmProject.git
```
Definir as configurações do usuário.
```
git config --local user.name nome
```
```
git config --local user.email email@gmail
```

Verificar a branch.
```
git branch 
```

Baixar as atualizações.
```
git pull
```

Adicionar todos os arquivos modificados no staging area - área de preparação.
```
git add .
```

commit representa um conjunto de alterações em um ponto específico da história do seu projeto, registra apenas as alterações adicionadas ao índice de preparação.
O comando -m permite que insira a mensagem de commit diretamente na linha de comando.
```
git commit -m "Descrição do commit"
```

Enviar os commits locais, para um repositório remoto.
```
git push <remote> <dztmProject>
git push origin dztmProject 
```


