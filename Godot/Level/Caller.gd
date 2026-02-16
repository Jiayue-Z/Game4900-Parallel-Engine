extends Node3D

@export var receiver: Node3D
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("Hello Friend")
	receiver.OnCalled()
