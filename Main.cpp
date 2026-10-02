#include <iostream>
#include <string>

extern "C" const char* GetNativeMessage()
{
    return "Hello from native C++!";
}
int main()
{
    std::cout << "VSL_CODIUM_AVALONIA Native Module Running..." << std::endl;

    std::string input;
    while (true)
    {
        std::cout << "> ";
        std::getline(std::cin, input);

        if (input == "exit")
            break;

        std::cout << "You typed: " << input << std::endl;
    }

    return 0;
}
