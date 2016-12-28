#ifndef __LOGGER_H__
#define __LOOGER_H__
#include <string>
#include <fstream>
#include <time.h>

class Logger
{
private:
	static Logger* _Instance;
	Logger();
	~Logger();
public:
	static Logger* getInstance();
	void write_text_to_log_file(const std::string &text);
};
#endif // !__LOGGER_H__