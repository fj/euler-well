# Removes all Unicode BOMs from files and converts Windows CRLF to Unix LF.

find . -path '*/.git/*' -prune -o -type f -print |                           \
  while read line;                                                           \
    do                                                                       \
      dd if="$line" 2>/dev/null | od -x | grep -q 'efbbbf' && echo "$line";  \
    done |                                                                   \
  while read line;                                                           \
    do                                                                       \
      echo [[[ $line;                                                        \
      dd if="$line" of="$line.result" ibs=3 skip=1;                          \
      diff "$line" "$line.result";                                           \
      dos2unix -v "$line.result";                                            \
      mv -v "$line.result" "$line"                                           \
      echo ]]];                                                              \
    done
