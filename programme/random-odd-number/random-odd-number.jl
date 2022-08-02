#Programme to generate random odd number in Julia in range

function oddGenerator(start,finish)
  choice = rand(start:finish)
  while choice % 2 == 0
    choice = rand(start:finish)
  end
  println(choice)
end

oddGenerator(0,100)
