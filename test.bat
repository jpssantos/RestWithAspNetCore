set mydate=%date:~10,4%%date:~6,2%/%date:~4,2%
git add --all 
git commit -m mydate
git push