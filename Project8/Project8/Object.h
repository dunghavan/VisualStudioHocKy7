#ifndef _OBJECT_H_
#define _OBJECT_H_
#include "Global.h"
#include"GSprite.h"
#include"Camera.h"
class Object
{
protected:
	GSprite *Sprite;
	GTexture *Texture;
	int x;
	int y;
	int width;
	int height;
public:
	Object();
	Object(int x, int y);
	~Object();
	virtual void Draw();
	virtual void Update(int);
	void SetX(int);
	void SetY(int);
	int GetX();
	int GetY();
};
#endif