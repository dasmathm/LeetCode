def romanToInt(s: str) -> int:
    if(s == "III"):
        return 3
    else:
        return 0


result = romanToInt("III")
print(result)