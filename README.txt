# AlterEgo

Esse é o código fonte do jogo Alter Ego.

Foi desenvolvido inicialmente entre fevereiro/junho de 2022 na engine Renpy. Mas devido a muitas limitações dessa engine, resolvi recriar o jogo inteiro
e aproveitando pra recriar todos os assets, dar uma vida nova ao game, da maneira como eu pranejei desde o início.

------------

-----------------Comandos para converter LF em CRLF---------
Acesse o terminal do git bash;

Acesse o diretório onde está os arquivos do projeto:
cd /c/Saphire Game Studio/Projetos Unity/AlterEgoClone/AlterEgo

Dps solte esse comando no terminal:
git config --global core.autocrlf true

E dps converta os arquivos do terminal de LF (linux) para CRL (windows):
converte de LF para CRLF:

find . -type f -exec unix2dos.exe {} \;

Se tudo der certo, vc já vai poder commitar e dar o push no github.

Bônus: (Caso vc precise):
# converte de CRLF para LF:
find . -type f -exec dos2unix.exe {} \; 