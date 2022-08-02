#Programme to calculate index of an alphabet

function chars(char)
  char = Int(char)
  
  if char >= 97
    
    small = Int('a')
    println(char - small + 1)

  else
    
    capital = Int('A')
    println(char - capital + 1)
  end
  
end

chars('C')
