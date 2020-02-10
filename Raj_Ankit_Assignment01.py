class Raj_Ankit_Assignment01:
        def main():
            n4 = 6
            if n4%4 == 0:
                print(False)
            else:
                array = [1]

                n4 = n4 - 1
                while n4 > 0:
                    if n4 - 3 > 0:
                        array.append(3)
                        n4 = n4 - 3
                    else:
                        array.append(n4)
                        n4 = 0
                print(array)

        if __name__ == '__main__':
            main()

        
