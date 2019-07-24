has_high_income = True
has_good_credit = True
has_criminal_record = False

if has_high_income and has_high_income:
    print("Eligible for loan (AND)")

if has_high_income or has_high_income:
    print("Eligible for loan (OR)")

if has_good_credit and not has_criminal_record:
    print("Eligible for loan (NOT)")

