#ifndef _BACK_GROUND_H_
#define _BACK_GROUND_H_

#include"Object.h"
class BackGround :public Object
{
public:
	BackGround(int x, int y);
	void Draw();
};
#endif