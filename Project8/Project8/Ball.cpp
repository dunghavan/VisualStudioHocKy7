#include"Ball.h"

#define BALL_IMAGE_FILE "ball.bmp"
#define BALL_WIDTH 25
#define BALL_HEIGHT 25
CBall::CBall(
	int X,
	int Y,
	float Vx,
	float Vy) :Object(X, Y)
{
	this->Vx = Vx;
	this->Vy = Vy;
	Texture = new GTexture("ball3.png", 10, 1, 10);
	Sprite = new GSprite(Texture, 60);
	width = Texture->FrameWidth;
	height = Texture->FrameHeight;
}

CBall::~CBall()
{
	if (Texture != NULL)
		delete Texture;
	if (Sprite != NULL)
		delete Sprite;
}
void CBall::Draw()
{	
	D3DXVECTOR2 pos = Camera.Transform(x, y);
	Sprite->Draw(pos.x,pos.y);
	
}
void CBall::Update(int t)
{
	//
	// Update position
	//
	x += Vx*t;
	y += Vy*t;

	RECT rect;
	rect.left = x;
	rect.top = y;
	rect.right = x + Texture->FrameWidth;
	rect.bottom = y + Texture->FrameHeight;
	//
	// Test collision with Screen
	//
	/*if ((rect.right > G_ScreenWidth) || (rect.left < 0))
	{
		Vx = -Vx;
	}

	if ((rect.bottom > G_ScreenHeight) || (rect.top < 0))
	{
		Vy = -Vy;
	}*/
	if (Vx!=0||Vy!=0)
	Sprite->Update(t);
	//else Sprite->_timeLocal = 0;
	
}
void CBall::SetVx(float vx)
{
	this->Vx = vx;
}
void CBall::SetVy(float vy)
{
	this->Vy = vy;
}
float CBall::GetVx()
{
	return  Vx;
}
float CBall::GetVy()
{
	return Vy;
}
int CBall::GetWidth()
{
	return width;
}
int CBall::GetHeight()
{
	return height;
}