extends Node

var attack_held := false

func _process(_delta: float) -> void:
	if Input.is_action_just_pressed("Attack"):
		attack_held = true
		print("Attack!!")
