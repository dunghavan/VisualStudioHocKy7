#ifndef _BALL_H_
#define _BALL_H_
#include<d3d9.h>
#include<d3dx9.h>
#include"Global.h"
#include"Object.h"
class CBall : public Object
{
	float Vx;
	float Vy;
public:
	CBall(int, int, float, float);
	~CBall();
	void Update(int t);
	void Draw();
	void Next(int t, int ScreenWidth, int ScreenHeight);
	void SetVx(float vx);
	void SetVy(float vy);
	float GetVx();
	float GetVy();
	int GetWidth();
	int GetHeight();
};
#endif