# Spacedual
משחק דו קרב בין שני משתתפים. קח פיקוד על החללית ופגע שלושה פעמים ביריב שלך על מנת לנצח!

## הקוד
שתי החלליות נשארות בגבולות המסך באמצעות scripts\1-mover\stayInbounds.

ניתן לשלוט בחללית השמאלית (שחקן 1) באמצעות מקשי החצים ו-left shift, בעוד שבחללית הימנית (שחקן 2) ניתן לשלוט בעזרת מקשי wasd ו-right shift.
הקוד נמצא ב - scripts\1-mover\InputMover וגם ב- InputMoverWASD

כאשר השחקן משיג 3 פגיעות, הוא מועבר לסצנה שמודיעה על ניצחונו (scripts\4-levels\NumberField)

אם שני החלליות מתנגשות אחת בשניה, המשחק נגמר ואף אחד לא מנצח (scripts\4-levels\GotoNextLevel).