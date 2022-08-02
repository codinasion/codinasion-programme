#Programme to generate random even number in Julia

function evenGenerator(start,finish)
  choice = rand(start:finish)
  while choice % 2 != 0
    choice = rand(start:finish)
  end
  println(choice)
end

evenGenerator(0,100)
