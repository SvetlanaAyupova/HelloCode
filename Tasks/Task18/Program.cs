// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

void CheckTruth(bool X, bool Y)
{
    Console.WriteLine($"!({X} || {Y}) = {!(X || Y)}, !{X} && !{Y} = {!X && !Y}");
}

CheckTruth(false, false);
CheckTruth(false, true);
CheckTruth(true, false);
CheckTruth(true, true);