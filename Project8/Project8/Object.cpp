#include"Object.h"

Object::Object()
{

}
Object::Object(int x, int y)
{
	this->x = x;
	this->y = y;

}
Object::~Object()
{

}
void Object::Draw()
{

}
void Object::Update(int t)
{

}
int Object::GetX()
{
	return this->x;
}
int Object::GetY()
{
	return this->y;
}
void Object::SetX(int X)
{
	x = X;
}
void Object::SetY(int Y)
{
	y = Y;
}